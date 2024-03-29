import { Avatar, Button, Card, CardActions, CardContent, CardHeader, Typography } from '@mui/material';
import TwitterIcon from '@mui/icons-material/Twitter';
import { Mention } from '../../app/models/mention';

interface Props {
  mention: Mention;
}
export default function FeedCard({ mention }: Props) {
  return (
     <Card  sx={{mb:2}}>
         <CardHeader
             avatar={
                 <Avatar sx={{bgcolor: 'secondary.main'}}>
                     {mention.sourceUserId.charAt(0).toUpperCase()}
                 </Avatar>
             }
             title={mention.region + '-' + mention.sourceUserId}
             titleTypographyProps={{
                 sx: {fontWeight: 'bold', color: 'primary.main'}
             }}
             
         />
         {/* <CardMedia
        component="img"
        sx={{ width: 50 }}
        image="/static/images/cards/live-from-space.jpg"
        alt="commenter photo"
      /> */}
     <CardContent>
       <Typography sx={{ fontSize: 14 }} color="text.secondary" gutterBottom>
       <a href="http://twitter.com/">{mention.mentionEnglish}</a>
       </Typography>
      
    
     </CardContent>
     <CardActions>
       <Button size="small">{mention.region}</Button> 
       <Button size="small">{mention.keyTerms}</Button> 
       <Button size="small">{mention.brand}</Button> 
       <TwitterIcon />
     </CardActions>
   </Card>
 );
}
