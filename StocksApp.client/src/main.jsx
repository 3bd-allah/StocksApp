import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App, {loader as DataLoader } from './App.jsx'
import { createBrowserRouter, RouterProvider } from 'react-router'
const router = createBrowserRouter([
  {path:'/', element: <App /> , loader: DataLoader}
])

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <RouterProvider router={router} />
  </StrictMode>,
)
