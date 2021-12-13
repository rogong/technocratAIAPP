import React, { useEffect, useState } from 'react'
import { Grid } from '@mui/material';
import { Mention } from '../../app/models/mention'
import FeedList from './FeedList'



export default function Feed() {

  const [mentions, setMentions] = useState<Mention[]>([]);

  useEffect(() => {
    fetch('http://localhost:5053/api/Mention')
      .then((response) => response.json())
      .then((data) => setMentions(data));
  }, []);

    return (
        <>
  
      <Grid container spacing={1}>
        <Grid item xs>
         Left Bar
        </Grid>
        <Grid item xs={6}>
          
          <FeedList mentions={mentions} />
          
        </Grid>
        <Grid item xs>
          Right Bar
        </Grid>
      </Grid>
    
        </>
    )
}
