import { lazy, StrictMode } from "react";
import { createRoot } from "react-dom/client";
import "./index.css";
import { loader as DataLoader } from "./components/CompanyProfile.jsx";
import { createBrowserRouter, RouterProvider } from "react-router";
import App from "./App.jsx";
// import CompanyProfile from "./components/CompanyProfile.jsx";

const CompanyProfile = lazy(() => import("./components/CompanyProfile.jsx"));

const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    errorElement: <p>Failed to load data, please try again later.</p>,
    children: [
      {
        path:'company',
        element: <CompanyProfile />,
        loader: ()=> import('./components/CompanyProfile.jsx').then(module => module.loader()),
      },
    ],
  },
]);

createRoot(document.getElementById("root")).render(
  <StrictMode>
    <RouterProvider router={router} />
  </StrictMode>,
);
