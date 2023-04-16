// Import the functions you need from the SDKs you need
import { initializeApp } from "firebase/app";
import { getAnalytics } from "firebase/analytics";
// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
  apiKey: "AIzaSyDyjCfzx45dSTKlJQaaTDDJw1o0OXDYuYc",
  authDomain: "capstoneproject1902710.firebaseapp.com",
  databaseURL: "https://capstoneproject1902710-default-rtdb.firebaseio.com",
  projectId: "capstoneproject1902710",
  storageBucket: "capstoneproject1902710.appspot.com",
  messagingSenderId: "564140169379",
  appId: "1:564140169379:web:6217e2628d43e36aa58716",
  measurementId: "G-00TLK3ZDDN"
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);
const analytics = getAnalytics(app);
export default app;
 