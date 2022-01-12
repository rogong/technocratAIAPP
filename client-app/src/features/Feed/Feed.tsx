import { useEffect } from 'react';
import { Button, Grid, Paper, Typography } from '@mui/material';
import FeedList from './FeedList';
import LoadingComponent from '../../app/layout/LoadingComponent';
import { useAppDispatch, useAppSelector } from '../../app/store/configureStore';
import {
  feedSelectors,
  fetchFeedsAsync,
  fetchFilters,
  setFeedParams,
  setPageNumber,
} from './feedSlice';
import FeedSearch from './FeedSearch';
import RadioButtonGroup from '../../app/components/RadioButtonGroup';
import CheckboxButtons from '../../app/components/CheckboxButtons';
import AppPagination from '../../app/components/AppPagination';

const sortOptions = [
  { value: 'dateDesc', label: 'Date - New to Old' },
  { value: 'date', label: 'Date - Old to New' },
];
export default function Feed() {
  const mentions = useAppSelector(feedSelectors.selectAll);
  const {
    feedsLoaded,
    filtersLoaded,
    datasources,
    markets,
    regions,
    products,
    brands,
    competitions,
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
    
    <>
      <Grid container spacing={1} sx={{ mt: 6 }}>
        {/* Left Side */}
        <Grid item xs>
          <Paper sx={{ mb: 2 }}>
            <Button variant="contained" color="primary">
              Start Tracking
            </Button>
          </Paper>
        </Grid>
        {/* Left Side Ends */}
        <Grid item xs={6}>
          <FeedList mentions={mentions} />
         {metaData &&
          <AppPagination
            metaData={metaData}
            onPageChange={(page: number) =>
              dispatch(setPageNumber({ pageNumber: page }))
            }
          />}
        </Grid>
        {/* Right Side */}
        <Grid item xs>
          <Paper sx={{ mb: 2 }}>
            <FeedSearch />
          </Paper>
          <Paper sx={{ mb: 2, p: 2 }}>
          <Typography variant="h6" sx={{fontWeight: 'bold', color: 'InfoText'}}>New/Old</Typography>
            <RadioButtonGroup
              selectedValue={feedParams.orderBy}
              options={sortOptions}
              onChange={(e) =>
                dispatch(setFeedParams({ orderBy: e.target.value }))
              }
            />
          </Paper>
          
          <Paper sx={{ mb: 2, p: 2 }}>
            <Typography variant="h6" sx={{fontWeight: 'bold', color: 'InfoText'}}>Brand</Typography>
            <CheckboxButtons
           
          items={brands.filter(x => x !== null)}
          checked={feedParams.brands}
              onChange={(items: string[]) =>
            dispatch(setFeedParams({ brands: items }))
              }
            />
            </Paper>

          <Paper sx={{ mb: 2, p: 2 }}>
            <Typography variant="h6" sx={{fontWeight: 'bold', color: 'InfoText'}}>Data Source</Typography>
            <CheckboxButtons
              items={datasources}
              checked={feedParams.datasources}
              onChange={(items: string[]) =>
                dispatch(setFeedParams({ datasources: items }))
              }
            />
          </Paper>
          <Paper sx={{ mb: 2, p: 2 }}>
            <Typography variant="h6" sx={{fontWeight: 'bold', color: 'InfoText'}}>Market</Typography>

            <CheckboxButtons
              items={markets}
              checked={feedParams.markets}
              onChange={(items: string[]) =>
                dispatch(setFeedParams({ markets: items }))
              }
            />
          </Paper>
          <Paper sx={{ mb: 2, p: 2 }}>
            <Typography variant="h6" sx={{fontWeight: 'bold', color: 'InfoText'}}>Region</Typography>
            <CheckboxButtons
              items={regions}
              checked={feedParams.regions}
              onChange={(items: string[]) =>
                dispatch(setFeedParams({ regions: items }))
              }
            />
          </Paper>
          <Paper sx={{ mb: 2, p: 2 }}>
            <Typography variant="h6" sx={{fontWeight: 'bold', color: 'InfoText'}}>Product</Typography>
            <CheckboxButtons
              items={products}
              checked={feedParams.products}
              onChange={(items: string[]) =>
                dispatch(setFeedParams({ products: items }))
              }
            />
          </Paper>
          <Paper sx={{ mb: 2, p: 2 }}>
            <Typography variant="h6" sx={{fontWeight: 'bold', color: 'InfoText'}}>Competitors</Typography>
            <CheckboxButtons
           
          items={competitions.filter(x => x !== null)}
          checked={feedParams.competitions}
              onChange={(items: string[]) =>
            dispatch(setFeedParams({ competitions: items }))
              }
            />
            </Paper>
        </Grid>
      </Grid>
    </>
  );
}
