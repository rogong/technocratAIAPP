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
    <List>
      {mentions.map(mention => (
        <Grid>
          {!feedsLoaded ? (
          <FeedCardSkeleton />
        ) : (
          <FeedCard key={mention.id} mention={mention} />
        )}
        </Grid>
      ))}
    </List>
  );
}
