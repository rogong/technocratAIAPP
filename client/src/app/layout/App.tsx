import { createTheme, CssBaseline, ThemeProvider } from '@mui/material';
import { useState } from 'react';
import Feed from '../../features/Feed/Feed';


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
    
 
    <Feed  />
      
    </ThemeProvider>
  );
}

export default App;
