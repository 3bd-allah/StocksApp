import OrderCard from "./OrderCard";

const OrderList = ({ title, orders = [], isLoading }) => (
  <div className="w-full bg-gray-50/80 border border-gray-300 rounded-lg p-6 shadow-sm min-h-[400px]">
    <h2 className="text-gray-600 font-semibold text-sm mb-5">{title}</h2>

    {isLoading ? (
      <div className="text-gray-400 text-sm py-8 text-center">Loading orders...</div>
    ) : orders.length === 0 ? (
      <div className="text-gray-400 text-sm py-8 text-center">No orders available.</div>
    ) : (
      <div className="flex flex-col gap-5">
        {orders.map((order, index) => (
          <OrderCard key={order.id || index} order={order} />
        ))}
      </div>
    )}
  </div>
);

export default OrderList; 