import OrderList from "./OrderList"

const SellOrders = ({sellOrders = [], isLoading}) => {
  return <OrderList title={"Sell Orders"} orders={sellOrders} isLoading={isLoading}/>
}

export default SellOrders