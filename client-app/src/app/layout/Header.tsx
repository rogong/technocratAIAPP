import {
  AppBar,
  Box,
  List,
  ListItem,
  Switch,
  Toolbar,
  Typography,
} from '@mui/material';
import { NavLink } from 'react-router-dom';
import { useAppSelector } from '../store/configureStore';
import SignedInMenu from './SignedInMenu';
import HomeOutlinedIcon from '@mui/icons-material/HomeOutlined';
import InfoOutlinedIcon from '@mui/icons-material/InfoOutlined';
import ContactPageOutlinedIcon from '@mui/icons-material/ContactPageOutlined';
import LoginOutlinedIcon from '@mui/icons-material/LoginOutlined';
import LockOpenOutlinedIcon from '@mui/icons-material/LockOpenOutlined';
import   { makeStyles} from '@mui/styles';

interface Props {
  darkMode: boolean;
  handleThemeChange: () => void;
}

const homeLinks = [
  { title: 'home', path: '/', icon: <HomeOutlinedIcon /> },
  { title: 'about', path: '/about', icon: <InfoOutlinedIcon /> },
  { title: 'contact', path: '/contact', icon: <ContactPageOutlinedIcon /> },
];


const rightLinks = [
  { title: 'features', path: '/features', icon: <LoginOutlinedIcon /> },
  { title: 'login', path: '/login', icon: <LoginOutlinedIcon /> },
  { title: 'FreeTrial', path: '/register', icon: <LockOpenOutlinedIcon/> },
];

const navStyles = {
  color: 'inherit',
  textDecoration: 'none',
  '&:hover': {
    color: 'gray.500',
  },
  '&.active': {
    color: 'text.secondary',
  },
};
const useStyle = makeStyles({
  header: {
    background: "#2874f0",
    height: 50,
  },
});
export default function Header({ darkMode, handleThemeChange }: Props) {
  const { user } = useAppSelector((state) => state.account);
  const classes = useStyle();
  return (
    <AppBar position="fixed"   className={classes.header}
    sx={{ mb: 1,}}>
      <Toolbar
        sx={{
          display: 'flex',
          alignItems: 'center',
          justifyContent: 'space-between',
        }}
      >
        <Box display="flex" alignItems="center">
          <Typography component={NavLink} to="/" sx={navStyles}>
            Technocrat
          </Typography>
          <Switch
            checked={darkMode}
            onChange={handleThemeChange}
            inputProps={{ 'aria-label': 'controlled' }}
          />
        </Box>
        {!user &&
        <List sx={{ display: 'flex' }}>
          {homeLinks.map(({ title, path}) => (
            <ListItem component={NavLink} to={path} key={path} sx={navStyles}>
            
              {title.charAt(0).toUpperCase() + title.slice(1)}
            </ListItem>
          ))}
        </List>
        }

        {user ? (
          <SignedInMenu />
        ) : (
          <Box display="flex" alignItems="center">
            <List sx={{ display: 'flex' }}>
              {rightLinks.map(({ title, path }) => (
                <ListItem
                  component={NavLink}
                  to={path}
                  key={path}
                  sx={navStyles}
                >
                  
                  {title.charAt(0).toUpperCase() + title.slice(1)}
                </ListItem>
              ))}
            </List>
          </Box>
        )}
      </Toolbar>
    </AppBar>
  );
}
