import { Box, Button, Grid, Paper, styled, Typography } from '@mui/material';
import { useEffect } from 'react';
import FeedList from '../../../features/Feed/FeedList';
import { feedSelectors, fetchFeedsAsync, fetchFilters } from '../../../features/Feed/feedSlice';
import LoadingComponent from '../../layout/LoadingComponent';
import { useAppSelector, useAppDispatch } from '../../store/configureStore';
import Barchart from '../chart/Barchart';


const Item = styled(Paper)(({ theme }) => ({
    ...theme.typography.body2,
    padding: theme.spacing(1),
    textAlign: 'center',
    color: theme.palette.text.secondary,
  }))
  
export default function RightResultPage() {
    const mentions = useAppSelector(feedSelectors.selectAll);
    const {
      feedsLoaded,
      filtersLoaded,
      datasources,
      markets,
      regions,
      products,
      feedParams,
      metaData,
    } = useAppSelector((state) => state.feed);
    const dispatch = useAppDispatch();
  
    useEffect(() => {
      if (!feedsLoaded) dispatch(fetchFeedsAsync());
    }, [feedsLoaded, dispatch]);
  
    useEffect(() => {
      if (!filtersLoaded) dispatch(fetchFilters());
    }, [filtersLoaded, dispatch]);
  
    if (!filtersLoaded)
      return <LoadingComponent message="Loading Feeds..." />;
      
  return (
    <Box display="grid" gridTemplateColumns="repeat(12, 1fr)" gap={2}>
      <Box gridColumn="span 8">
     
      <FeedList mentions={mentions} />
      
      </Box>
      <Box gridColumn="span 4">
       <Grid>
           
         <Item>
             <Button>View Details</Button>
         <Typography variant="h6">
             Total Mentions
             
             </Typography>
         <Typography variant="h6">116</Typography>

         <Barchart />
         </Item>
       </Grid>
      </Box>
      </Box>
  );
}
