import axios, { AxiosError, AxiosResponse } from "axios";
import { toast } from "react-toastify";
import { history } from "../..";
import { PaginatedResponse } from "../models/pagination";

axios.defaults.baseURL = 'http://localhost:5053/api/';

const responseBody = (response: AxiosResponse) => response.data;

axios.interceptors.response.use(response => {
    const pagination = response.headers['pagination'];

    if(pagination){
        response.data = new PaginatedResponse(response.data, JSON.parse(pagination));
       return response;
    }
    return response
}, (error: AxiosError) => {
    const {data, status} = error.response!;
    switch (status) {
        case 400:
            if(data.errors){
                const modelStateErrors: string[] = [];
                for (const key in data.errors) {
                    if(data.errors[key]) {
                        modelStateErrors.push(data.errors[key])
                    }
                }
                throw modelStateErrors.flat();
            }
            toast.error(data.title);
            break;
        case 401:
            toast.error(data.title);
            break;
        case 500:
            history.push({
                pathname: '/server-error',
                state: {error: data}
            });
            break;
    
        default:
            break;
    }
    return Promise.reject(error.response);
})

const requests = {
    get: (url: string, params?: URLSearchParams) => axios.get(url, {params}).then(responseBody),
    post: (url: string) => axios.post(url).then(responseBody),
    put: (url: string) => axios.put(url).then(responseBody),
    delete: (url: string) => axios.delete(url).then(responseBody),
}

const Feed = {
    list: (params: URLSearchParams) => requests.get('mention', params),
    fetchFilters: () => requests.get('mention/filters')
    
}

const TestErrors = {
    get400Error: () => requests.get('buggy/bad-request'),
    get401Error: () => requests.get('buggy/unauthorised'),
    get404Error: () => requests.get('buggy/not-found'),
    get500Error: () => requests.get('buggy/server-error'),
    getValidationError: () => requests.get('buggy/validation-error'),
}

const agent = {
    Feed,
    TestErrors
}

export default agent;