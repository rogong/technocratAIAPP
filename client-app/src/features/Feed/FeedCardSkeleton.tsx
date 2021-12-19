import { Card, CardActions, CardContent, CardHeader, Grid, Skeleton } from '@mui/material';

export default function FeedCardSkeleton() {
  return (
    <Grid item xs component={Card}>
      <CardHeader
        avatar={
          <Skeleton
            animation="wave"
            variant="circular"
            width={40}
            height={40}
          />
        }
        title={
          <Skeleton
            animation="wave"
            width="80%"
            height={10}
            style={{ marginBottom: 6 }}
          />
        }
      />
      <Skeleton
        animation="wave"
        variant="rectangular"
        width={40}
        sx={{ height: 40 }}
      />
      <CardContent>
          <>
          <Skeleton animation="wave"  height={10} style={{ marginBottom: 6 }} />
          </>
      </CardContent>
      <CardActions>
          <>
          <Skeleton
            animation="wave"
            width="40%"
            height={10}
          />
          <Skeleton
            animation="wave"
            width="20%"
            height={10}
          />
          </>
      </CardActions>
    </Grid>
  );
}
