import { useState, useEffect } from 'react';
import CalculadoraImc from "./components/CalculadoraImc"

function App() {

  const [datos, setDatos] = useState([])
  const [fetched, setFetched] = useState(true);


  useEffect(() => {

    if (fetched) {
      fetch('https://localhost:7194/WeatherForecast')
        .then((response) => response.json())
        .then((dataResponse) => {
          setTodoListItems(dataResponse.data)
        });

      setFetched(false);
    }

  }, [fetched]);

  return (
    <>
      <div className="container mx-auto mt-8">
        <CalculadoraImc
          datos={datos}
          setDatos={setDatos}
        />
      </div>
    </>
  )
}

export default App
