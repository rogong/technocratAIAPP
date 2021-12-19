import { AppBar, Box, List, ListItem, Switch, Toolbar, Typography } from '@mui/material'
import { NavLink } from 'react-router-dom'


interface Props {
    darkMode: boolean;
    handleThemeChange: () => void;
}

const homeLinks = [
    {title: 'home', path: '/home'},
    {title: 'about', path: '/about'},
]
const midLinks = [
   
    {title: 'feed', path: '/feed'},
    {title: 'export', path: '/export'},
    {title: 'report', path: '/report'},
    {title: 'digest', path: '/digest'},
    {title: 'alert', path: '/alert'}
]

const rightLinks = [
    {title: 'features', path: '/features'},
    {title: 'login', path: '/login'},
    {title: 'FreeTrial', path: '/register'}
]

const navStyles = {
color: 'inherit', 
textDecoration: 'none',
'&:hover': {
    color: 'gray.500'
},
'&.active': {
    color: 'text.secondary'
}
}

export default function Header({darkMode, handleThemeChange}: Props) {
    return (
        <AppBar position='static' sx={{ mb: 1 }}>
          <Toolbar sx={{display: 'flex', alignItems: 'center', justifyContent: 'space-between'}}>
            <Box display='flex' alignItems='center'>

            <Typography variant='h6' component={NavLink} to='/'
          sx={navStyles }>
                AI Project
            </Typography>
            <Switch
      checked={darkMode}
      onChange={handleThemeChange}
      inputProps={{ 'aria-label': 'controlled' }}
    />
                
            </Box>

            <List sx={{display: 'flex'}}>
        {homeLinks.map(({title, path}) => (
            <ListItem
            component={NavLink}
            to={path}
            key={path}
            sx={navStyles }
            >
                {title.charAt(0).toUpperCase() + title.slice(1)}
            </ListItem>
        ))}
    </List>

          
    <List sx={{display: 'flex'}}>
        {midLinks.map(({title, path}) => (
            <ListItem
            component={NavLink}
            to={path}
            key={path}
            sx={navStyles }
            >
                {title.charAt(0).toUpperCase() + title.slice(1)}
            </ListItem>
        ))}
    </List>

    <Box display='flex' alignItems='center'>
    <List sx={{display: 'flex'}}>
        {rightLinks.map(({title, path}) => (
            <ListItem
            component={NavLink}
            to={path}
            key={path}
            sx={navStyles }
            >
                {title.charAt(0).toUpperCase() + title.slice(1)}
            </ListItem>
        ))}
    </List>
    </Box>
    
          </Toolbar>
        </AppBar>
    )
}
