import { Button, Container, Divider, Paper, Typography } from '@mui/material'
import { useHistory, useLocation } from 'react-router-dom';



export default function ServerError(){
  const history = useHistory();
  const {state} = useLocation<any>();

    return (
      <Container component={Paper}>
       {state?.error ? (
          <>
          <Typography variant='h4' color='error' gutterBottom>{state.error.title}</Typography>
          <Divider />
          <Typography>{state.error.detail || 'Internal server error'}</Typography>
          </>
        ) : (
          <Typography variant='h5' gutterBottom>Server error</Typography>
        )}
         
         <Button onClick={() => history.push('/feed')}>Go back to the page</Button>
      </Container>
    )
}
