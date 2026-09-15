import axios from "axios";


const personsApi = axios.create({
    baseURL:'http://localhost:5115',
    headers:{
        "Content-Type": "application/x-www-form-urlencoded"
    }
})

const countryApi = axios.create({
    baseURL:'http://localhost:5115/api'
})

const stocksApi = axios.create({
    baseURL:'http://localhost:5099/api'
})
export { personsApi, countryApi, stocksApi }