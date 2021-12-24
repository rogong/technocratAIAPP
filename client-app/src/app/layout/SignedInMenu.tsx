import { Button, List, ListItem, Menu, MenuItem } from "@mui/material";
import React from "react";
import { NavLink } from "react-router-dom";
import { signOut } from "../../features/account/accountSlice";
import { useAppDispatch, useAppSelector } from "../store/configureStore";
import SettingsOutlinedIcon from '@mui/icons-material/SettingsOutlined';
import FeedOutlinedIcon from '@mui/icons-material/FeedOutlined';
import AssessmentOutlinedIcon from '@mui/icons-material/AssessmentOutlined';
import ImportExportOutlinedIcon from '@mui/icons-material/ImportExportOutlined';
import AddAlertOutlinedIcon from '@mui/icons-material/AddAlertOutlined';
import AcUnitOutlinedIcon from '@mui/icons-material/AcUnitOutlined';
import HelpCenterOutlinedIcon from '@mui/icons-material/HelpCenterOutlined';

const midLinks = [
    { title: 'feed', path: '/feed', icon: <FeedOutlinedIcon /> },
    { title: 'export', path: '/export',icon: <ImportExportOutlinedIcon /> },
    { title: 'report', path: '/report', icon: <AssessmentOutlinedIcon /> },
    { title: 'digest', path: '/digest',icon: <AcUnitOutlinedIcon /> },
    { title: 'alert', path: '/alert',icon: <AddAlertOutlinedIcon /> },
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
  
export default function SignedInMenu() {
    const dispatch = useAppDispatch();
    const {user} = useAppSelector(state => state.account);
    const [anchorEl, setAnchorEl] = React.useState<null | HTMLElement>(null);
    const [anchorHelp, setAnchorHelp] = React.useState<null | HTMLElement>(null);
    const open = Boolean(anchorEl);
    const openHelp = Boolean(anchorHelp);
    const handleClick = (event: React.MouseEvent<HTMLButtonElement>) => {
      setAnchorEl(event.currentTarget);
    };
    const handleHelpClick = (event: React.MouseEvent<HTMLButtonElement>) => {
      setAnchorHelp(event.currentTarget);
    };
    const handleClose = () => {
      setAnchorEl(null);
      setAnchorHelp(null);
    };
  
    return (
      <>
          <List sx={{display: 'flex'}}>
     {midLinks.map(({title, path, icon}) => (
         <ListItem
         component={NavLink}
         to={path}
         key={path}
         sx={navStyles }
         >
             {icon}
             {title.charAt(0).toUpperCase() + title.slice(1)}
         </ListItem>
       
     ))}
 </List>

      <Button 
        color='inherit'
        onClick={handleHelpClick}
            >
          Help
          <HelpCenterOutlinedIcon/>
        </Button>
        <Menu
          anchorEl={anchorHelp}
          open={openHelp}
          onClose={handleClose}
          MenuListProps={{
            'aria-labelledby': 'basic-button',
          }}
        >
          
          <MenuItem onClick={handleClose}>FAQ</MenuItem>
          <MenuItem onClick={handleClose}>What's New</MenuItem>
          <MenuItem onClick={() => dispatch(signOut())}>Video tutorial</MenuItem>
          <MenuItem onClick={() => dispatch(signOut())}>
Help me filter result</MenuItem>
<MenuItem onClick={() => dispatch(signOut())}>
Repplay tutorial</MenuItem>
        </Menu>
     
        




 
        <Button 
        color='inherit'
        onClick={handleClick}>
          {user?.userName}
          <SettingsOutlinedIcon />
        </Button>
        <Menu
          anchorEl={anchorEl}
          open={open}
          onClose={handleClose}
          MenuListProps={{
            'aria-labelledby': 'basic-button',
          }}
        >
          
          <MenuItem onClick={handleClose}>Account settings</MenuItem>
          <MenuItem onClick={handleClose}>Payment settings</MenuItem>
          <MenuItem onClick={() => dispatch(signOut())}>Logout</MenuItem>
        </Menu>
      </>
    );
}
