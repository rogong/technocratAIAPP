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
            <RadioButtonGroup
              selectedValue={feedParams.orderBy}
              options={sortOptions}
              onChange={(e) =>
                dispatch(setFeedParams({ orderBy: e.target.value }))
              }
            />
          </Paper>

          <Paper sx={{ mb: 2, p: 2 }}>
            <Typography variant="h6">Data Source</Typography>
            <CheckboxButtons
              items={datasources}
              checked={feedParams.datasources}
              onChange={(items: string[]) =>
                dispatch(setFeedParams({ datasources: items }))
              }
            />
          </Paper>
          <Paper sx={{ mb: 2, p: 2 }}>
            <Typography variant="h6">Market</Typography>

            <CheckboxButtons
              items={markets}
              checked={feedParams.markets}
              onChange={(items: string[]) =>
                dispatch(setFeedParams({ markets: items }))
              }
            />
          </Paper>
          <Paper sx={{ mb: 2, p: 2 }}>
            <Typography variant="h6">Region</Typography>
            <CheckboxButtons
              items={regions}
              checked={feedParams.regions}
              onChange={(items: string[]) =>
                dispatch(setFeedParams({ regions: items }))
              }
            />
          </Paper>
          <Paper sx={{ mb: 2, p: 2 }}>
            <Typography variant="h6">Product</Typography>
            <CheckboxButtons
              items={products}
              checked={feedParams.products}
              onChange={(items: string[]) =>
                dispatch(setFeedParams({ products: items }))
              }
            />
          </Paper>
        </Grid>
      </Grid>
    </>
  );
}
