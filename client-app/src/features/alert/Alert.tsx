import * as React from 'react';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import Paper from '@mui/material/Paper';
import { Button, Grid } from '@mui/material';



export default function Alert() {
  return (
    <Grid container spacing={1} sx={{mt: 8}}>
      <Grid item xs={2}>

      </Grid>
   
      <Grid item xs={8}>
        <Button variant='contained'>Add New Alert</Button>
      <TableContainer component={Paper}>
      <Table  aria-label="simple table">
        <TableHead>
          <TableRow>
            <TableCell>Feed Name</TableCell>
            <TableCell align="right">Export</TableCell>
            <TableCell align="right">Schedule</TableCell>
            <TableCell align="right">Actions</TableCell>
         
          </TableRow>
        </TableHead>
        <TableBody>
            <TableRow
              key={1}
            
            >
              <TableCell component="th" scope="row">
                Mastercard
              </TableCell>
              <TableCell align="right">Mention in mail</TableCell>
              <TableCell align="right">Everyday at 8:0 am</TableCell>
              <TableCell align="right">
                <Button>Edit</Button>
                <Button>Duplicate</Button>
                <Button color='error'>Delete</Button>
              </TableCell>
             
            </TableRow>
        
        </TableBody>
      </Table>
    </TableContainer>
        
      </Grid>

 <Grid item xs={2}>
        
      </Grid>

      

 </Grid>
   
  );
}