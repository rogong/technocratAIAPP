import { Grid, List } from '@mui/material';

import { Mention } from '../../app/models/mention';
import { useAppSelector } from '../../app/store/configureStore';
import FeedCard from './FeedCard';
import FeedCardSkeleton from './FeedCardSkeleton';

interface Props {
  mentions: Mention[];
}
export default function FeedList({ mentions }: Props) {
  const {feedsLoaded} = useAppSelector(state => state.feed);
  return (
    <List >
      {mentions.map((mention,index) => (
        <Grid key={index}>
          {!feedsLoaded ? (
          <FeedCardSkeleton />
        ) : (
          <FeedCard  mention={mention} />
        )}
        </Grid>
      ))}
    </List>
  );
}
