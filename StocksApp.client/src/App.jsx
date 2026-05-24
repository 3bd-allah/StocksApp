import './App.css'
import { Link, Outlet, useLoaderData } from 'react-router'
import { Suspense } from 'react';
import { lazy } from 'react';
const CompanyProfile = lazy(()=> import('./components/CompanyProfile'))


function App() {
  
  return (
    <>
      <section >
          <Link to='/company' relative='route'>
            To Company
          </Link>
      </section>
      <Outlet />
    </>
  )
}

export default App




