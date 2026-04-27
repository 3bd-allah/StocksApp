import './App.css'
import { useLoaderData } from 'react-router'

function App() {
  const {stockSymbol, stockName, price, quantity} = useLoaderData(); 
  return (
    <>
      <section id="center">
        <h4>{stockName} ( <span>{stockSymbol}</span> )</h4>
        <p>$ {price}</p>
      </section>
    </>
  )
}

export default App


export const loader = async ()=>{
 const response  = await fetch("http://localhost:5000/company-profile")
 return await response.json();
}