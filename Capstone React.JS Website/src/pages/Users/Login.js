import React from 'react'
import { getAuth, signInWithEmailAndPassword } from "firebase/auth";
import { useState } from "react";
import app from '../../firebase';
import Footer from '../Footer/Footer'
import './signup.css'

function Login() {

    const auth = getAuth(app);

    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");

    const Login = () => {
        signInWithEmailAndPassword(auth, email, password)
        .then((userCredential) => {
            // Signed in 
            const user = userCredential.user;
            console.log(user);
            alert("User Logged In");
        })
        .catch((error) => {
            const errorCode = error.code;
            const errorMessage = error.message;
            alert(errorMessage);
        });
    }

  return (
    <div className='auth-container'>
        <div className='auth-wrapper'>
            <div className="auth-section">
                <h1>Login</h1>
                <input type={"email"} placeholder="Enter your email" onChange={(e) => setEmail(e.target.value)} />
                <input type={"password"} placeholder="Enter your password" onChange={(e) => setPassword(e.target.value)} />

                <button onClick={Login}>Login</button>
                <h2>Don't have an account with us? Sign up below</h2>
                <a href='/signup'><button>Signup</button></a>
            </div>
        </div> 
        <Footer />   
    </div>
  )
}

export default Login