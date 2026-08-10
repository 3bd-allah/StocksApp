import axios from "axios";


axios.defaults.baseURL = "http://localhost:5115"

axios.defaults.headers.common["Content-Type"] = "application/json"

// axios.defaults.headers.common["Accept"] = "application/json"

axios.defaults.xsrfCookieName ='XSRF-TOKEN-COOKIE';
axios.defaults.xsrfHeaderName='X-XSRF-TOKEN'
axios.defaults.withXSRFToken=true;