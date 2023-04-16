import React from 'react'
import './purchase.css'
import Footer from '../Footer/Footer'

function Purchase() {
  return (
    <div className='purchase-container'>
        <div className='page-title'>
            <h1>Purchase</h1>
            <h2>Pick up the game today!</h2>
        </div>
        <div className='purchase-about'>
            <div className='half-container2'>
              <img src={require("../../assets/poster2.png")} alt='enemies'></img>
            </div>
            <div className='half-container'>
            <h1>Medieval Magic - Available Now!</h1>
                <p>Dive into an action packed world of magical tower defense NOW!<br/>
                Pick your edition of the game below: </p>
                <div className='edition-description'>
                    <h3>Standard Edition</h3>
                    <p>Standard Edition includes the base game!</p>
                    <h3>Expansion Pass (TBA)</h3>
                    <p>Expansion Pass includes three extra levels</p>
                    <h3>Level Boost (TBA)</h3>
                    <p>Instantly boost your account to level 50 and get a head start!</p>
                </div>
                <div class="btn-group">
                    <button class="button">Standard Edition - Free </button>
                    <button class="button">Expansion Pass (TBA) - £5.99 </button>
                    <button class="button">Level Boost (TBA) - £3.99</button>
                  </div>
                
                  <a href="https://swiftyair.itch.io/medieval-magic" target="_blank">
                    <button type="submit" className="btn btn-primary"> Buy Now </button>
                  </a>
            </div>
        </div>
        <Footer />   
    </div>
  )
}

export default Purchase