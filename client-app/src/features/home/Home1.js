import React, { Component } from "react";

// Importing Section
import Clients from "./components/Clients";
import Contact from "./components/Contact";
import Footer from "./components/Footer/Footer";
import Pricing from "./components/Pricing";
import Services from "./components/Services";
import Team from "./components/Team";
import Section from "./Section1";
import "./assets/css/materialdesignicons.min.css";

import "./assets/scss/themes.scss";


class Home extends Component {
  constructor(props) {
    super(props);
    this.state = {
      navItems: [
        { id: 1, idnm: "home", navheading: "Home" },
        { id: 3, idnm: "services", navheading: "Services" },
        { id: 4, idnm: "pricing", navheading: "Pricing" },
        { id: 5, idnm: "team", navheading: "Team" },
        { id: 6, idnm: "clients", navheading: "Clients" },
        { id: 7, idnm: "contact", navheading: "Contact" },
      ],
      pos: document.documentElement.scrollTop,
      imglight: false,
      navClass: "",
      fixTop : true
    };
  }

  componentDidMount() {
    window.addEventListener("scroll", this.scrollNavigation, true);
  }

  componentWillUnmount() {
    window.removeEventListener("scroll", this.scrollNavigation, true);
  }

  scrollNavigation = () => {
    var scrollup = document.documentElement.scrollTop;
    if (scrollup > this.state.pos) {
      this.setState({ navClass: "nav-sticky", imglight: false });
    } else {
      this.setState({ navClass: "", imglight: false });
    }
  };

  render() {
    return (
      <React.Fragment>
          {/* Importing Navbar */}
          {/* <Navbar
            navItems={this.state.navItems}
            navClass={this.state.navClass}
            imglight={this.state.imglight}
            top={this.state.fixTop}
          /> */}

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
      </React.Fragment>
    );
  }
}
export default Home;
