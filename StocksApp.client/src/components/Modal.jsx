import { useEffect, useRef } from "react";

const Modal = ({ children, onClose }) => {
  const dialog = useRef();

  useEffect(() => {
    const modal = dialog.current;
    modal.showModal();

    return () => {
      modal.close();
    };
  }, []);
  return (
    <dialog
      ref={dialog}
      onClose={onClose}
      className="
        fixed inset-0 z-50 w-full max-w-xl p-0 m-auto
        flex flex-col max-h-[90vh]
        bg-white rounded-2xl shadow-2xl border border-gray-100
        backdrop:bg-gray-900/50 backdrop:backdrop-blur-sm
        outline-none
      "
    >
      {children}
    </dialog>
  );
};

export default Modal;
