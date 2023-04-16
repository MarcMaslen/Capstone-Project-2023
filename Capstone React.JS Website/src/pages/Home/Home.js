import React from 'react';
import Hero from "../hero/Hero";
import About from "../about/About";
import BuyNowPage from "../buynow/Buynow";
import Contact from "../contact/Contact";
import Footer from "../Footer/Footer";

//Main app component for the website. Combines all my main pages together.
function Home() {
  return (
    <>
        <Hero />
        <About />
        <BuyNowPage />
        <Contact />
        <Footer />
      </>
  );
}

export default Home;
