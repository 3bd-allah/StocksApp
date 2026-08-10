import { useNavigate } from "react-router";
import Modal from "../../components/Modal";
import { useEffect, useState } from "react";

const DeletePersonModal = ({ person, onDelete }) => {
  const [progressValue, setProgressValue] = useState(0);
  const navigate = useNavigate();

  // BUG: in this component the deletion request sends more than once to the backend 
  useEffect(() => {
    const timer = setInterval(() => {
      if(progressValue < 1){
        setProgressValue(prev => prev +.2);
      }
      if(progressValue ===1 ){
        clearInterval(timer);
        onDelete();
        return ;
      }
    }, 1000);
    return () => clearInterval(timer);
  }, [progressValue, onDelete]);

  const handleCloseModal = () => {
    navigate('/persons');
  };

  return (
    <Modal>
      <progress className="w-full" value={progressValue} />
      <h2>Delete Person</h2>
      <p>
        Are you sure that you want to delete '{person?.personName}' permanently
      </p>
      <button onClick={handleCloseModal}>Cancel</button>
    </Modal>
  );
};

export default DeletePersonModal;
