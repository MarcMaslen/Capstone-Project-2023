import React from 'react'
import './button.css'


//Reuseable button for my react website. 
function button({onClick, children}) {
  return (
    <div>
      <button className='button-ctn' type='button' onClick={onClick}>{children}</button>
    </div>
  );
};

export default button;