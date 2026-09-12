import Skeleton from "react-loading-skeleton";
import "react-loading-skeleton/dist/skeleton.css";
const StockCardSkeleton = () => {
  return (
    <div className="w-full bg-white border border-gray-200 rounded-lg p-6 shadow-sm flex flex-col justify-between min-h-[450px]">
      <div>
        {/* Company Logo Container */}
        {/* We keep the black square background layout container so the layout size stays consistent */}
        <div className="w-32 h-32 bg-slate-100 rounded-lg flex items-center justify-center p-4 mb-4">
          <Skeleton
            width="100%"
            height="100%"
            containerClassName="w-full h-full block"
          />
        </div>

        {/* Stock Title & Symbol */}
        <div className="mb-2">
          <Skeleton height={32} width="75%" />
        </div>

        {/* Category Badge */}
        <div className="mb-3">
          <Skeleton height={24} width={100} />
        </div>

        {/* Exchange Information */}
        <div className="flex items-center gap-2 mb-6">
          <Skeleton height={20} width={70} />
          <Skeleton height={24} width={80} />
        </div>

        {/* Stock Price Display */}
        <div className="mt-2">
          <Skeleton height={48} width={160} />
        </div>
      </div>

      {/* Trade Now Button */}
      <div className="mt-8">
        <Skeleton height={40} width={110} />
      </div>
    </div>
  );
};

export default StockCardSkeleton;


// plain tailwind css 

// <div className="w-full bg-white border border-gray-200 rounded-lg p-6 shadow-sm flex flex-col justify-between min-h-[450px]">
//   {/* Root skeleton wrapper with the pulse animation effect */}
//   <div className="animate-pulse">
//     {/* Company Logo Container */}
//     <div className="w-32 h-32 bg-slate-200 rounded-lg mb-4"></div>

//     {/* Stock Title & Symbol */}
//     <div className="h-8 bg-slate-200 rounded-md w-3/4 mb-2"></div>

//     {/* Category Badge */}
//     <div className="mb-3">
//       <div className="h-5 bg-slate-200 rounded w-24"></div>
//     </div>

//     {/* Exchange Information */}
//     <div className="flex items-center gap-2 mb-6">
//       <div className="h-4 bg-slate-200 rounded w-16"></div>
//       <div className="h-5 bg-slate-200 rounded w-20"></div>
//     </div>

//     {/* Stock Price Display */}
//     <div className="flex items-baseline gap-1 mt-2">
//       <div className="h-12 bg-slate-200 rounded-md w-36"></div>
//     </div>
//   </div>

//   {/* Trade Now Button placeholder */}
//   <div className="mt-8 animate-pulse">
//     <div className="h-10 bg-slate-200 rounded-md w-28"></div>
//   </div>
// </div>

// ================================================================

// skeleton

//       <div className="w-full bg-white border border-gray-200 rounded-lg p-6 shadow-sm flex flex-col justify-between min-h-[450px]">
//   <div>
//     {/* Company Logo Container */}
//     {/* We keep the black square background layout container so the layout size stays consistent */}
//     <div className="w-32 h-32 bg-slate-100 rounded-lg flex items-center justify-center p-4 mb-4">
//       <Skeleton width="100%" height="100%" containerClassName="w-full h-full block" />
//     </div>

//     {/* Stock Title & Symbol */}
//     <div className="mb-2">
//       <Skeleton height={32} width="75%" />
//     </div>

//     {/* Category Badge */}
//     <div className="mb-3">
//       <Skeleton height={24} width={100} />
//     </div>

//     {/* Exchange Information */}
//     <div className="flex items-center gap-2 mb-6">
//       <Skeleton height={20} width={70} />
//       <Skeleton height={24} width={80} />
//     </div>

//     {/* Stock Price Display */}
//     <div className="mt-2">
//       <Skeleton height={48} width={160} />
//     </div>
//   </div>

//   {/* Trade Now Button */}
//   <div className="mt-8">
//     <Skeleton height={40} width={110} />
//   </div>
// </div>
