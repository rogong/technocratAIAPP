import {
  Box,
  Button,
  debounce,
  Divider,
  Grid,
  IconButton,
  InputBase,
  Menu,
  MenuItem,
  Typography,
} from '@mui/material';
import MenuIcon from '@mui/icons-material/Menu';
import SearchIcon from '@mui/icons-material/Search';
import DirectionsIcon from '@mui/icons-material/Directions';
import Paper from '@mui/material/Paper';
import SaveIcon from '@mui/icons-material/Save';
import Allofthewords from '../../app/components/search/Allofthewords';
import Someofthewords from '../../app/components/search/Someofthewords';
import Noneofthewords from '../../app/components/search/Noneofthewords';
import FilterAltIcon from '@mui/icons-material/FilterAlt';
import SourceSharpIcon from '@mui/icons-material/SourceSharp';
import RightResultPage from '../../app/components/search/RightResultPage';
import React, { useEffect } from 'react';
import { useAppDispatch, useAppSelector } from '../../app/store/configureStore';
import LoadingComponent from '../../app/layout/LoadingComponent';
import { fetchFeedsAsync, fetchFilters, setFeedParams } from '../Feed/feedSlice';
import CheckboxButtons from '../../app/components/CheckboxButtons';
import  {useState} from 'react';


export default function SearchResults() {
  const [anchorEl, setAnchorEl] = useState<null | HTMLElement>(null);
  const [anchorFilter, setAnchorFilter] = useState<null | HTMLElement>(null);
  const openEl = Boolean(anchorEl);
  const openFilter = Boolean(anchorFilter);
  const handleClick = (event: React.MouseEvent<HTMLButtonElement>) => {
    setAnchorEl(event.currentTarget);
  };
  const handleFilterClick = (event: React.MouseEvent<HTMLButtonElement>) => {
    setAnchorFilter(event.currentTarget);
  };
  const handleClose = () => {
    setAnchorEl(null);
    setAnchorFilter(null);
  };
  const handleSearchToggle = () => {
      setBasicSearch(true);
      setAdvancedSearch(false);
  };

  const handleAdvancedSearchToggle = () => {
    setBasicSearch(false);
    setAdvancedSearch(true);
  };

  const {
    feedsLoaded,
    filtersLoaded,
    datasources,
    regions,
    feedParams,
  } = useAppSelector((state) => state.feed);
  const dispatch = useAppDispatch();
  const [searchTerm, setSearchTerm] = useState(' ');
  const [basicSearch, setBasicSearch] = useState(false)
  const [advancedSearch, setAdvancedSearch] = useState(true)


  const debouncedSearch = debounce((event: any) => {
      dispatch(setFeedParams({searchTerm: event.target.value}))
  }, 1000)


  useEffect(() => {
    if (!feedsLoaded) dispatch(fetchFeedsAsync());
  }, [feedsLoaded, dispatch]);

  useEffect(() => {
    if (!filtersLoaded) dispatch(fetchFilters());
  }, [filtersLoaded, dispatch]);

  if (!filtersLoaded)
    return <LoadingComponent message="Loading Feeds..." />;

    

  return (
    <>
    { basicSearch &&
        <Box sx={{mt: 6}}>
        <Grid container spacing={3}>
          <Grid item xs={2}></Grid>
          <Grid item xs={8}>
            <Typography variant="h4" sx={{ mb: 2, mt: 2 }}>
              Enter your kewords?
            </Typography>

            <Paper
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
                onChange={(event:any) => {
                  setSearchTerm(event.target.value);
                  debouncedSearch(event);
              }}
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
          </Grid>
          <Grid item xs={2}></Grid>
        </Grid>
      </Box>
    }

      {/* Display Result */}
     
     
      <Box sx={{ mt: 12, mr: 2, ml: 2 }}>
     
  {advancedSearch &&
        <Grid container spacing={3}>
          <Grid item xs={4}>
      
            <Allofthewords  />
            
          </Grid>
          <Grid item xs={4}>
          <Someofthewords />
          </Grid>
          <Grid item xs={4}>
            <Noneofthewords />
          </Grid>
         
        </Grid>
       }
        <Divider light sx={{mb: 5}} />
      
      </Box>
      <Box>
      <Grid container sx={{m:3}} >
          <Grid item xs={8}>

          {
        advancedSearch &&
        <Button variant="outlined" onClick={handleSearchToggle}>
        Switch to Basic Search
        </Button>
      }
      {
        basicSearch &&
        <Button variant="outlined" onClick={handleAdvancedSearchToggle}>
        Switch to Advanced Search
        </Button>
      }
          </Grid>
          <Grid item xs={4}>
                {/* Filter Menu and Button */}
          <Button variant="outlined"  onClick={handleFilterClick}>
            <FilterAltIcon />
            Filter</Button>

            <Menu
          anchorEl={anchorFilter}
          open={openFilter}
          onClose={handleClose}
          MenuListProps={{
            'aria-labelledby': 'basic-button',
          }}
        >
          <MenuItem onClick={handleClose}>
          <Typography variant="h6">Region</Typography>
          <CheckboxButtons
              items={regions}
              checked={feedParams.regions}
              onChange={(items: string[]) =>
                dispatch(setFeedParams({ regions: items }))
              }
            
            />
          </MenuItem>
          
          </Menu>
            {/* Filter Menu Ends */}


          {/* Filter by Datasource starts */}
          <Button variant="outlined" onClick={handleClick}>
            <SourceSharpIcon />
            Source</Button>

            <Menu
          anchorEl={anchorEl}
          open={openEl}
          onClose={handleClose}
          MenuListProps={{
            'aria-labelledby': 'basic-button',
          }}
        >
          <MenuItem onClick={handleClose}>
          <Typography variant="h6">Data Source</Typography>
            <CheckboxButtons
              items={datasources}
              checked={feedParams.datasources}
              onChange={(items: string[]) =>
                dispatch(setFeedParams({ datasources: items }))
              }
            />
          </MenuItem>
          
          </Menu>

          {/* Filter by Datasource ends */}
          
          

           <Button variant="contained">
            <SaveIcon />
            Save Query</Button>
          </Grid>
      </Grid>

      </Box>
      
      <Box sx={{mr: 2, ml: 2}}>
        
      
        <RightResultPage />
      </Box>
     
    </>
  );
}
