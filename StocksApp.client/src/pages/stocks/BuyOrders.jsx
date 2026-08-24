import OrderList from "./OrderList"

const BuyOrders = ({buyOrders = [], isLoading}) => {
  return <OrderList title={"Buy Orders"} orders={buyOrders} isLoading={isLoading} />
}

export default BuyOrders