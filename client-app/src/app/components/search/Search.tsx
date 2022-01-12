import {
    Box,
    Divider,
    Grid,
    IconButton,
    InputBase,
    Typography,
  } from '@mui/material';
  import MenuIcon from '@mui/icons-material/Menu';
  import SearchIcon from '@mui/icons-material/Search';
  import DirectionsIcon from '@mui/icons-material/Directions';
  import Paper from '@mui/material/Paper';
 
  
  
  import  {useState} from 'react';
  import axios from 'axios';
  import { Redirect } from 'react-router-dom';
  
  
  export default function BasicSearch() {
    
    const [searchTerm, setSearchTerm] = useState(' ');
    const [results, setResults] = useState<any>([]);
  
   const onChangeTerm = ((e: any) => {
      setSearchTerm( e.target.value)
    });
  
    const onSubmit = ((e:any) => {
      let url = 'http://localhost:5053/api/Mention?SearchTerm=' + encodeURI(searchTerm) ;
      axios.get(url)
        .then(response => {
          let data = {
            results: response.data,
          };
          setResults(data);
        })
        .catch(error => console.log(error));
    });
  
  
    return (
      <>
        <Box sx={{mt: 6}}>
          <Grid container spacing={3}>
            <Grid item xs={2}></Grid>
            <Grid item xs={8}>
              <Typography variant="h4" sx={{ mb: 4, mt: 4 }}>
                What are you looking for today?
              </Typography>
  
              <Paper
              onSubmit={onSubmit}
                component="form"
                sx={{
                  p: '2px 4px',
                  display: 'flex',
                  alignItems: 'center',
                  width: 700,
                }}
              >
                <IconButton sx={{ p: '10px' }} aria-label="menu">
                  <MenuIcon />
                </IconButton>
                <InputBase
                  sx={{ ml: 1, flex: 1 }}
                  placeholder="search for a brand, hashtag or topic"
                  inputProps={{ 'aria-label': 'search google maps' }}
                  onChange={onChangeTerm}
                  type="text"
                  value={searchTerm}
                />
                <IconButton type="submit" sx={{ p: '10px' }} aria-label="search">
                  <SearchIcon />
                </IconButton>
                <Divider sx={{ height: 28, m: 0.5 }} orientation="vertical" />
                <IconButton
                  color="primary"
                  sx={{ p: '10px' }}
                  aria-label="directions"
                >
                  <DirectionsIcon />
                </IconButton>
              </Paper>
              {results.length > 0 &&
            <Redirect to={{
              pathname: '/searchresults',
              state: { results: results }
            }}/>}
            </Grid>
            <Grid item xs={2}></Grid>
          </Grid>
        </Box>
  
        {/* Display Result */}
        <Divider light />
     
      </>
    );
  }
  