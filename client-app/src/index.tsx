import React from 'react';
import ReactDOM from 'react-dom';
import App from './app/layout/App';
import reportWebVitals from './reportWebVitals';
import { Router } from 'react-router-dom';
import { createBrowserHistory } from 'history';
import 'slick-carousel/slick/slick.css';
import 'slick-carousel/slick/slick-theme.css';
import { Provider } from 'react-redux';
import { store } from './app/store/configureStore';
import { fetchFeedsAsync } from './features/Feed/feedSlice';



export const history = createBrowserHistory();
store.dispatch(fetchFeedsAsync());

ReactDOM.render(
  <React.StrictMode>
    <Router history={history}>
    
        <Provider store={store}>
        <App />
        </Provider>
    
    </Router>
  </React.StrictMode>,
  document.getElementById('root')
);


reportWebVitals();
