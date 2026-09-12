/* eslint-disable react-refresh/only-export-components */
import { lazy, StrictMode } from "react";
import { createRoot } from "react-dom/client";
import "./index.css";
import { createBrowserRouter, RouterProvider } from "react-router";
import { QueryClientProvider } from "@tanstack/react-query";
import PersonsSection from "./pages/persons/PersonsSection.jsx";
// global axios configuration
import "./api/configuration/axios-global-config.js";
import App from "./App.jsx";
import RootErrorBoundary from "./routes/RootErrorBoundary.jsx";
import { loader as personDetailsLoader } from "./routes/PersonDetails.jsx";
import { queryClient } from "./queries/queryClient.js";
import DeletePerson from "./routes/DeletePerson.jsx";
import PersonDetails from "./routes/PersonDetails.jsx";
import DownloadAsPDF from "./routes/DownloadAsPDF.jsx";
import StocksExplore from "./pages/stocks/StocksExplore.jsx";
import StocksOrders from "./pages/stocks/StocksOrders.jsx";
import StocksLandingPage from "./pages/stocks/StocksLandingPage.jsx";
// lazy loading
const Persons = lazy(() => import("./routes/Persons.jsx"));
const UploadCountries = lazy(()=> import('./routes/UploadCountries.jsx'))
const EditPerson = lazy(()=> import('./routes/EditPerson.jsx'))
const CompanyProfile = lazy(() => import("./routes/Company.jsx"));
const NewPerson = lazy(() => import("./routes/NewPerson.jsx"));
const Stocks = lazy(()=> import('./routes/Stocks.jsx'));

const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    errorElement: <RootErrorBoundary />,
    children: [
      {
        path: "stocks",
        element: <Stocks />,
        children:[
          {index: true, element:<StocksLandingPage />},
          {path: 'explore', element: <StocksExplore /> },
          {path: 'orders', element: <StocksOrders />},
          {path: 'trade', element: <CompanyProfile />}

        ]
      },
      {
        path: "persons",
        element: <Persons />,
        children: [
          { index: true, element: <PersonsSection /> },
          { path: "create-new", element: <NewPerson /> },
          { path: "download", element: <DownloadAsPDF />,  },
          {
            path: ":personId",
            loader: personDetailsLoader,
            children: [
              { index: true, element: <PersonDetails /> },
              { path: "edit", element: <EditPerson /> },
              { path: "delete", element: <DeletePerson /> },
            ],
          },
        ],
      },
      {
        path:'country',
        element:<UploadCountries />,
        
      }
    ],
  },
]);

createRoot(document.getElementById("root")).render(
  <StrictMode>
    <QueryClientProvider client={queryClient}>
      <RouterProvider router={router} />
    </QueryClientProvider>
  </StrictMode>
);
