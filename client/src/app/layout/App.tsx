import { createTheme, CssBaseline, ThemeProvider } from '@mui/material';
import { useState } from 'react';
import { Route, Routes } from 'react-router-dom';
import AboutPage from '../../features/about/AboutPage';
import Alert from '../../features/alert/Alert';
import Digest from '../../features/digest/Digest';
import Export from '../../features/export/Export';
import Feed from '../../features/Feed/Feed';
import Home from '../../features/home/Home';


import Header from './Header';



function App() {
  const [darkMode, setDarkMode] = useState(false);
  const paletteType = darkMode ? 'dark' : 'light';

  const theme = createTheme({
    palette: {
      mode: paletteType,
      background: {
        default: paletteType === 'light' ? '#eaeaea' : '#121212'
      }
    }
  })
  
function handleThemeChange(){
   setDarkMode(!darkMode);
}
  return (
<ThemeProvider  theme={theme}>
   <CssBaseline/>
    <Header darkMode={darkMode} handleThemeChange={handleThemeChange} />
    
 
    <Routes>
    <Route path='/' element={<Home />} />
    <Route path='/feed' element={<Feed />} />
    <Route path='/digest' element={<Digest />} />
    <Route path='/alert' element={<Alert />} />
    <Route path='/export' element={<Export />} />
    <Route path='/about' element={<AboutPage />} /> 
    </Routes>
      
    </ThemeProvider>
  );
}

export default App;
