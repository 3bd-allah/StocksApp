import { BeatLoader } from "react-spinners";

const Loading = ({className}) => {
  return (
    <div className={className}>
        <BeatLoader aria-label="loading" color="#9ea0a0" size={10} />
    </div>
)
}

export default Loading; 