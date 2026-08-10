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
export { personsApi, countryApi }