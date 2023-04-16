import React from 'react'
import './hero.css'
import { GiFire } from 'react-icons/gi'

//This is the hero section which is the first part that people with see when entering the website.

const Hero = () => {
  return (
    <div className='hero' id="hero">
        <div className='container'>
            <div className='content'>
                <h1>Medieval Magic!</h1>
                <h2 className='blue'>An <em>Award Winning</em> Tower Defense Experience Like Nothing You Have Seen Before! Download Now!!</h2>
                {/* <h2 className='blue'>Buy Now to find out!</h2> */}
                <div>
                  <a href="https://swiftyair.itch.io/medieval-magic" target="_blank">
                    <button type="submit" className="btn btn-primary"> Buy Now </button>
                  </a>
                </div>
            </div>
            {/*current picture is a place holder */}
            <div className='right-pic'>
              <GiFire className='logo-icon' />
            </div>
        </div>
    </div>
  )
}

export default Hero;



