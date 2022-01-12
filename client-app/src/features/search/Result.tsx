import { Box, Button, debounce, Divider, Grid, IconButton, InputBase, Menu, MenuItem, Paper, styled, Typography } from '@mui/material';
import axios from 'axios';
import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import Barchart from '../../app/components/chart/Barchart';
import CheckboxButtons from '../../app/components/CheckboxButtons';
import Allofthewords from '../../app/components/search/Allofthewords';
import Noneofthewords from '../../app/components/search/Noneofthewords';
import Someofthewords from '../../app/components/search/Someofthewords';
import LoadingComponent from '../../app/layout/LoadingComponent';
import { Mention } from '../../app/models/mention';
import FeedList from '../Feed/FeedList';
import { fetchFeedsAsync, fetchFilters, setFeedParams } from '../Feed/feedSlice';
import SearchIcon from '@mui/icons-material/Search';
import { useAppDispatch, useAppSelector } from '../../app/store/configureStore';
import SourceSharpIcon from '@mui/icons-material/SourceSharp';
import FilterAltIcon from '@mui/icons-material/FilterAlt';
import SaveIcon from '@mui/icons-material/Save';

const Item = styled(Paper)(({ theme }) => ({
  ...theme.typography.body2,
  padding: theme.spacing(1),
  textAlign: 'center',
  color: theme.palette.text.secondary,
}));

const Result = () => {
  const [anchorEl, setAnchorEl] = useState<null | HTMLElement>(null);
  const [anchorFilter, setAnchorFilter] = useState<null | HTMLElement>(null);
  const dispatch = useAppDispatch();

  const [basicSearch, setBasicSearch] = useState(false)
  const [advancedSearch, setAdvancedSearch] = useState(true)

  const { term } = useParams<{ term: string }>();
  const [termx, setTermx] = useState<string>(term)
  const [mentions, setMentions] = useState<Mention[] | null>(null);
  const [loading, setLoading] = useState(true);

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



  const debouncedSearch = debounce((event: any) => {
      dispatch(setFeedParams({termx: event.target.value}))
  }, 1000)


  useEffect(() => {
    if (!feedsLoaded) dispatch(fetchFeedsAsync());
  }, [feedsLoaded, dispatch]);

  useEffect(() => {
    if (!filtersLoaded) dispatch(fetchFilters());
  }, [filtersLoaded, dispatch]);

  useEffect(() => {
    axios
      .get(`http://localhost:5053/api/Mention?SearchTerm=${termx}`)
      .then((response) => setMentions(response.data.items))
      .catch((error) => console.log(error))
      .finally(() => setLoading(false));
  }, [termx]);

  if (!filtersLoaded)
    return <LoadingComponent message="Loading Feeds..." />;

  if (loading) return <LoadingComponent message="Loading Feeds..." />;

  if (!mentions) return <h3>No mention found</h3>;
  //console.log(mentions)
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
              
              <InputBase
                sx={{ ml: 1, flex: 1 }}
                placeholder="search for a brand, hashtag or topic"
                inputProps={{ 'aria-label': 'search google maps' }}
                onChange={(event:any) => {
                  setTermx(event.target.value);
                  debouncedSearch(event);
                  
              }}
                type="text"
                value={termx}
               
              />
              <IconButton type="submit" sx={{ p: '10px' }} aria-label="search">
                <SearchIcon />
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
      
            <Allofthewords  term={termx} />
            
          </Grid>
          <Grid item xs={4}>
          <Someofthewords termx={termx}  />
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



    <Box display="grid" gridTemplateColumns="repeat(12, 1fr)" gap={2} sx={{ml:2, mr:2}}>
      <Box gridColumn="span 8">
        <FeedList mentions={mentions} />
      </Box>
      <Box gridColumn="span 4">
        <Grid>
          <Item>
            <Button>View Details</Button>
            <Typography variant="h6">Total Mentions</Typography>
            <Typography variant="h6">116</Typography>

            <Barchart />
          </Item>
        </Grid>
      </Box>
    </Box>
    </>
  );
};

export default Result;
