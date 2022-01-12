import  { useState } from 'react';
import { Chip } from '@mui/material';
import { styled } from '@mui/material/styles';

interface ChipData {
    key: number;
    label: string;
  }
  
  const ListItem = styled('li')(({ theme }) => ({
    margin: theme.spacing(0.5),
  }));



export default function Allofthewords({term} : any) {
    const [chipData, setChipData] = useState<readonly ChipData[]>([
        { key: 0, label: term },
      
      ]);
      const handleDelete = (chipToDelete: ChipData) => () => {
        setChipData((chips) =>
          chips.filter((chip) => chip.key !== chipToDelete.key)
        );
      };
    return (
      <fieldset>
        {/* <Paper
              sx={{
                display: 'flex',
                justifyContent: 'center',
                flexWrap: 'wrap',
                listStyle: 'none',
                p: 0.5,
                m: 0,

              }}
              component="ul"
            > */}

           
               
              {chipData.map((data) => {
                let icon;

                // if (data.label === 'React') {
                //   icon = <TagFacesIcon />;
                // }

                return (
                
                 <ListItem key={data.key}>
                    <Chip
                      icon={icon}
                      label={data.label}
                      onDelete={
                        data.label === 'React' ? undefined : handleDelete(data)
                      }
                    />
                  </ListItem>
                 
                );
              })}
              
            {/* </Paper> */}
        </fieldset>
    )
}
