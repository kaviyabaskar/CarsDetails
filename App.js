import React, { useState } from 'react';
import axios from 'axios';
import "./App.css";


function App() {
  const [data, setData] = useState({})
  const [location, setLocation] = useState('')
 
  
  //const url = `https://localhost:7285/api/controller/GetCars?carnum=${location}`
  const url = `https://localhost:7285/api/controller/GetCars?carnum=${location}`

  //https://localhost:7285/api/controller/GetCars?carnum=892
  


  const searchLocation = (event) => {
    if (event.key === 'Enter') {
      axios.get(url).then((response) => {
        setData(response.data)
        console.log(response.data)
      })
     
    }
  }
  return (
    
    <div className="app">
    <div className="search">
        <input
          value={location}
          onChange={event => setLocation(event.target.value)}
          onKeyPress={searchLocation}
          placeholder='Enter car id'
          type="text" />
      </div>  
      <p><img src={data.imageUrl}alt={data.Tittle}></img></p>       
          <p>{data.locations}</p>         
          <p>{data.carname}</p>   
          <p>{data.companyname}</p>          
          <p>{data.modelnum}</p>  
                         
        </div>                    
  );
}
export default App;