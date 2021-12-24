
import Clients from "./components/Clients";
import Contact from "./components/Contact";
import Footer from "./components/Footer/Footer";
import Pricing from "./components/Pricing";
import Services from "./components/Services";
import Team from "./components/Team";
import Section from "./Section";
import "./assets/css/materialdesignicons.min.css";

import "./assets/scss/themes.scss";
import { Grid } from "@mui/material";

export default function Home() {

    return (
      <Grid sx={{backgroundColor: 'white'}}>
         

          {/* Importing Section */}
          <Section />

           {/* Importing Service */}
           <Services />

          {/* Importing Pricing */}
          <Pricing />

          {/* Importing Team */}
          <Team />

          {/* Importing Clients */}
          <Clients />

          {/* Importing Contact Us */}
          <Contact />

          {/* Importing Footer */}
          <Footer />
      </Grid>
    );
  
}

