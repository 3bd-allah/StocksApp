import { stocksApi } from "./configuration/axios-custom-config";
import { downloadFile } from "../utilities/downloadFile";

export async function getAllStocks({ signal, searchSymbol }) {
  let api = "/stocks";
  if (searchSymbol) {
    api += `/search?symbol=${searchSymbol}`;
  }
  try {
    const { data } = await stocksApi.get(api, { signal });
    return data.result ?? data;
  } catch (errEx) {
    const errorResponse = new Error(errEx);
    throw errorResponse;
  }
}

export async function getCompanyProfile({ signal, companySymbol }) {
  try {
    const { data } = await stocksApi.get("/trade/company-profile", {
      signal,
      params: {
        stockSymbol: companySymbol,
      },
    });
    return data;
  } catch (errEx) {
    return errEx.response?.data;
  }
}

export async function getAllOrders({ signal }) {
  try {
    const { data: allOrders } = await stocksApi.get("/trade/orders", {
      signal,
    });
    return allOrders;
  } catch (errEx) {
    const errorResponse = new Error(errEx.response);
    throw errorResponse;
  }
}

export async function downloadOrdersAsPdf({ signal }) {
  try {
    const { data: allOrders } = await stocksApi.get("/trade/orders-pdf", {
      signal,
      responseType: "blob",
    });
    downloadFile(allOrders, "All Orders.pdf");
  } catch (errEx) {
    const errorResponse = new Error(errEx.response);
    throw errorResponse;
  }
}

export async function createBuyOrder({ signal, buyOrderData }) {
  console.log(buyOrderData);
  try {
    const { data } = await stocksApi.post("/trade/buyOrder", buyOrderData, {
      signal,
    });
    return data;
  } catch (errEx) {
    const errorResponse = new Error(errEx.response);
    throw errorResponse;
  }
}

export async function createSellOrder({ signal, sellOrderData }) {
  try {
    const { data } = await stocksApi.post("/trade/sellOrder", sellOrderData, {
      signal,
    });
    return data;
  } catch (errEx) {
    const errorResponse = new Error(errEx.response);
    throw errorResponse;
  }
}

export async function getBuyOrdersInPages({ signal, nextCursor }) {
  try {
    const { data } = await stocksApi.query("/stocks/buy-orders", null, {
      signal,
      params: {
        after: nextCursor,
      },
    });
    return data;
  } catch (errEx) {
    const errorResponse = new Error(errEx.response);
    throw errorResponse;
  }
}

export async function getSellOrdersInPages ({signal, nextCursor}){

  try{
    const { data } = await stocksApi.get('/stocks/sell-orders',{
      signal,
      params:{
        after: nextCursor
      }
    })
    return data;
  }catch (errEx) {
    const errorResponse = new Error(errEx.response);
    throw errorResponse;
  }
}
