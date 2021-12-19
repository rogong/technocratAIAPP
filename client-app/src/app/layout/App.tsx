import {
  Container,
  createTheme,
  CssBaseline,
  ThemeProvider,
} from '@mui/material';
import { useState } from 'react';
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


function App() {
  
  //const [loading, setLoading] = useState(true);
  
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

      <Container>
      <Switch>
          
      <Route exact path="/" component={Home} />
        <Route path="/feed" component={Feed} />
        <Route path="/digest" component={Digest} />
        <Route path="/alert" component={Alert} />
        <Route path="/export" component={Export} />
        <Route path="/about" component={AboutPage} />
        <Route path="/contact" component={ContactPage} />
        <Route path="/server-error" component={ServerError} />
        <Route component={NotFound} />
      </Switch>
      </Container>
    </ThemeProvider>
  );
}

export default App;
