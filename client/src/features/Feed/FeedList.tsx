import { List } from '@mui/material';

import { Mention } from '../../app/models/mention';
import FeedCard from './FeedCard';

interface Props {
  mentions: Mention[];
}
export default function FeedList({ mentions }: Props) {
  return (
    <List>
      {mentions.map((mention) => (
        <FeedCard key={mention.id} mention={mention} />
      ))}
    </List>
  );
}
