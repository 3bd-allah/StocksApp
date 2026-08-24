import { stockDateFormatter } from "../../utilities/dateFormatters";

const OrderCard = ({ order }) => (
  <div className="pb-4 border-b border-gray-400 last:border-b-0 last:pb-0">
    <h3 className="text-base font-bold text-gray-900">
      {order.stockName} <span className="text-gray-800">({order.stockSymbol})</span>
    </h3>
    
    <div className="text-sm text-gray-800 mt-0.5">
      <span className="font-bold">{order.quantity}</span> shares at{' '}
      <span className="font-bold">${order.price?.toFixed(2)}</span>
    </div>

    <div className="text-xs text-gray-600 font-medium mt-2">
      Trade Amount: <span className="font-bold text-gray-900">${order.tradeAmount?.toFixed(2)}</span>
    </div>

    <div className="text-xs text-gray-400 font-normal mt-1">
      {stockDateFormatter(order.dateAndTimeOfOrder)}
    </div>
  </div>
);

export default OrderCard