import { Paper, TextField } from '@mui/material'


export default function Someofthewords({termx}: any) {
    return (
        <>
        <fieldset>
            <Paper>
            <TextField
          label="Some of these words"
         
          defaultValue="Add keywords or phrase"
        
          variant='outlined'
          fullWidth
        />
            </Paper>
            </fieldset>
            
        </>
    )
}
