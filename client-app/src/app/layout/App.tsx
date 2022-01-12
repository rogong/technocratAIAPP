import { createTheme, CssBaseline, ThemeProvider } from '@mui/material';
import { useEffect, useState } from 'react';
import { Route, Switch } from 'react-router-dom';
import { ToastContainer } from 'react-toastify';
import AboutPage from '../../features/about/AboutPage';
import Alert from '../../features/alert/Alert';
import Digest from '../../features/digest/Digest';
import Export from '../../features/export/Export';
import Feed from '../../features/Feed/Feed';
import Home from '../../features/home/Home';
import 'react-toastify/dist/ReactToastify.css';

import Header from './Header';
import ServerError from '../errors/ServerError';
import NotFound from '../errors/NotFound';
import ContactPage from '../../features/contact/ContactPage';
import Login from '../../features/account/Login';
import Register from '../../features/account/Register';
import basicSearch from '../../features/search/BasicSearch';
import Report from '../../features/report/Report';
import { useAppDispatch } from '../store/configureStore';
import { fectchCurrentUser } from '../../features/account/accountSlice';
import SearchResults from '../../features/search/SearchResults';
import Result from '../../features/search/Result';
import ForgetPasswordSuccess from '../components/successpages/ForgetPasswordSuccess';
import ForgetPassword from '../../features/account/ForgetPassword';
import VerifyEmail from '../../features/account/VerifyEmail';

function App() {
  const dispatch = useAppDispatch();
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    dispatch(fectchCurrentUser()).then(() => setLoading(false));
  }, [dispatch]);

  const [darkMode, setDarkMode] = useState(false);
  const paletteType = darkMode ? 'dark' : 'light';

  const theme = createTheme({
    palette: {
      mode: paletteType,
      background: {
        default: paletteType === 'light' ? '#eaeaea' : '#121212',
      },
    },
  });

  function handleThemeChange() {
    setDarkMode(!darkMode);
  }
  return (
    <ThemeProvider theme={theme}>
      <ToastContainer position="bottom-right" hideProgressBar theme="colored" />
      <CssBaseline />
      <Header darkMode={darkMode} handleThemeChange={handleThemeChange} />

      <Switch>
        <Route exact path="/" component={Home} />
        <Route path="/feed" component={Feed} />
        <Route path="/digest" component={Digest} />
        <Route path="/alert" component={Alert} />
        <Route path="/report" component={Report} />
        <Route path="/export" component={Export} />
        <Route path="/about" component={AboutPage} />
        <Route path="/contact" component={ContactPage} />
        <Route path="/login" component={Login} />
        <Route path="/register" component={Register} />
        <Route path="/forget-password" component={ForgetPassword} />
        <Route path="/verify-email" component={VerifyEmail} />
        <Route
          path="/forget-password-success-page"
          component={ForgetPasswordSuccess}
        />
        <Route path="/search" component={basicSearch} />
        <Route path="/searchresult" component={SearchResults} />
        <Route path="/result/:term" component={Result} />
        <Route path="/server-error" component={ServerError} />
        <Route component={NotFound} />
      </Switch>
    </ThemeProvider>
  );
}

export default App;
