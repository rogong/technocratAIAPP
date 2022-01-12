import { Mention, MentionParams } from '../../app/models/mention';
import {
  createAsyncThunk,
  createEntityAdapter,
  createSlice,
} from '@reduxjs/toolkit';
import agent from '../../app/api/agent';
import { RootState } from '../../app/store/configureStore';
import { MetaData } from '../../app/models/pagination';

interface FeedState {
  feedsLoaded: boolean;
  filtersLoaded: boolean;
  status: string;
  datasources: string[];
  markets: string[];
  regions: string[];
  products: string[];
  languages: string[];
  brands: string[];
  competitions: string[];
  feedParams: MentionParams;
  metaData: MetaData | null;
}

const feedsAdapter = createEntityAdapter<Mention>();

function getAxiosParams(feedParams: MentionParams) {
  const params = new URLSearchParams();
  params.append('pageNumber', feedParams.pageNumber.toString());
  params.append('pageSize', feedParams.pageSize.toString());
  params.append('orderBy', feedParams.orderBy);
  if (feedParams.searchTerm) params.append('searchTerm', feedParams.searchTerm);
  if (feedParams.datasources.length > 0)
    params.append('datasources', feedParams.datasources.toString());
  if (feedParams.markets.length > 0)
    params.append('markets', feedParams.markets.toString());
  if (feedParams.regions.length > 0)
    params.append('regions', feedParams.regions.toString());
  if (feedParams.products.length > 0)
    params.append('products', feedParams.products.toString());
  if (feedParams.languages.length > 0)
    params.append('languages', feedParams.languages.toString());
  if (feedParams.brands.length > 0)
    params.append('brands', feedParams.brands.toString());
  if (feedParams.competitions.length > 0)
    params.append('competitions', feedParams.competitions.toString());
  return params;
}

export const fetchFeedsAsync = createAsyncThunk<
  Mention[],
  void,
  { state: RootState }
>('feed/fetchFeedsAsync', async (_, thunkAPI) => {
  const params = getAxiosParams(thunkAPI.getState().feed.feedParams);
  try {
    const response = await agent.Feed.list(params);
    thunkAPI.dispatch(setMetaData(response.metaData));
    return response.items;
  } catch (error: any) {
    return thunkAPI.rejectWithValue({ error: error.data });
  }
});

export const fetchFilters = createAsyncThunk(
  'feed/fetchFilters',
  async (_, thunkAPI) => {
    try {
      return agent.Feed.fetchFilters();
    } catch (error: any) {
      return thunkAPI.rejectWithValue({ error: error.data });
    }
  }
);

function initParams() {
  return {
    pageNumber: 1,
    pageSize: 6,
    orderBy: 'name',
    datasources: [],
    markets: [],
    regions: [],
    products: [],
    languages: [],
    brands: [],
    competitions: []
  };
}

export const feedSlice = createSlice({
  name: 'feed',
  initialState: feedsAdapter.getInitialState<FeedState>({
    feedsLoaded: false,
    filtersLoaded: false,
    status: 'idle',
    datasources: [],
    markets: [],
    regions: [],
    products: [],
    languages: [],
    brands: [],
    competitions: [],
    feedParams: initParams(),
    metaData: null,
  }),
  reducers: {
    setFeedParams: (state, action) => {
      state.feedsLoaded = false;
      state.feedParams = {
        ...state.feedParams,
        ...action.payload,
        pageNumber: 1,
      };
    },
    setPageNumber: (state, action) => {
      state.feedsLoaded = false;
      state.feedParams = { ...state.feedParams, ...action.payload };
    },
    setMetaData: (state, action) => {
      state.metaData = action.payload;
    },
    resetFeedParams: (state) => {
      state.feedParams = initParams();
    },
  },
  extraReducers: (builder) => {
    builder.addCase(fetchFeedsAsync.pending, (state) => {
      state.status = 'pendingFetchFeeds';
    });
    builder.addCase(fetchFeedsAsync.fulfilled, (state, action) => {
      feedsAdapter.setAll(state, action.payload);
      state.status = 'idle';
      state.feedsLoaded = true;
    });
    builder.addCase(fetchFeedsAsync.rejected, (state, action) => {
      console.log(action.payload);
      state.status = 'idle';
    });
    builder.addCase(fetchFilters.pending, (state) => {
      state.status = 'pendingFetchFilters';
    });
    builder.addCase(fetchFilters.fulfilled, (state, action) => {
      state.datasources = action.payload.datasources;
      state.markets = action.payload.markets;
      state.regions = action.payload.regions;
      state.products = action.payload.products;
      state.languages = action.payload.languages;
      state.brands  = action.payload.brands;
      state.competitions = action.payload.competitions;
      state.status = 'idle';
      state.filtersLoaded = true;
    });
    builder.addCase(fetchFilters.rejected, (state, action) => {
      console.log(action.payload);
      state.status = 'idle';
    });
  },
});

export const feedSelectors = feedsAdapter.getSelectors(
  (state: RootState) => state.feed
);
export const { setFeedParams, resetFeedParams, setMetaData, setPageNumber } =
  feedSlice.actions;
