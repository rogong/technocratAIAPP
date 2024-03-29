import { createAsyncThunk, createSlice, isAnyOf } from "@reduxjs/toolkit";
import { FieldValues } from "react-hook-form";
import { toast } from "react-toastify";
import { history } from "../..";
import agent from "../../app/api/agent";
import { User } from "../../app/models/user";

interface AccountState{
    user: User | null;
}

const initialState: AccountState = {
    user: null
}

export const signInUser = createAsyncThunk<User, FieldValues>(
    'account/signInUser',
    async(data, thunkAPI) => {
        try {
           const user = await agent.Account.login(data);
           localStorage.setItem('user', JSON.stringify(user));
           return user;   
        } catch (error: any) {
            return thunkAPI.rejectWithValue({error: error.data});
        }
    }
)

export const fectchCurrentUser = createAsyncThunk<User>(
    'account/fetchCurrentUser',
    async(_, thunkAPI) => {
        thunkAPI.dispatch(setUser(JSON.parse(localStorage.getItem('user')!)));
        try {
           const user = await agent.Account.currentUser();
           localStorage.setItem('user', JSON.stringify(user));
           return user;   
        } catch (error: any) {
            return thunkAPI.rejectWithValue({error: error.data});
        }
    },
    {
        condition: () => {
            if (!localStorage.getItem('user')) return false;
        }
    }
)
export const accountSlice = createSlice({
    name: 'account',
    initialState,
    reducers: {
        signOut: (state) => {
            state.user = null;
            localStorage.removeItem('user');
            history.push('/');
        },
        setUser: (state, action) => {
            state.user = action.payload;
        }
    },
    extraReducers: (builder => {
        builder.addCase(fectchCurrentUser.rejected, (state) => {
            state.user = null;
            localStorage.removeItem('user');
            toast.error('Session expired - please login again');
            history.push('/');
        })
        builder.addMatcher(isAnyOf(signInUser.fulfilled, 
            fectchCurrentUser.fulfilled),(state, action) => {
                state.user = action.payload;
            });
        builder.addMatcher(isAnyOf(signInUser.rejected),(state, action) => {
                    console.log(action.payload);
                })
    })
})

export const {signOut, setUser} = accountSlice.actions;