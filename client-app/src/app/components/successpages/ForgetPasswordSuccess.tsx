import { CssBaseline, Box, Avatar, Typography } from "@mui/material"
import { Container } from "reactstrap"
import LockOutlinedIcon from '@mui/icons-material/LockOutlined';

const ForgetPasswordSuccess = () => {
    return (
        <Container component={'main'} maxWidth="xs">
        <CssBaseline />
        <Box
          sx={{
            marginTop: 8,
            display: 'flex',
            flexDirection: 'column',
            alignItems: 'center',
          }}
        >
          <Avatar sx={{ m: 1, bgcolor: 'secondary.main' }}>
            <LockOutlinedIcon />
          </Avatar>
          <Typography component="h4" variant="h5">
          Please check your email for password reset instructions
          </Typography>
          <Box>
              
          </Box>
         
  
        </Box>
      </Container>
    )
}

export default ForgetPasswordSuccess
