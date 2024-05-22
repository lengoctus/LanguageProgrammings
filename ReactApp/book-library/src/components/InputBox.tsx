import { Input } from "reactstrap";

interface IInputProps {
  id: string;
  name: string;
  placeholder: string;
  type: any;
}

const InputBox: React.FC<IInputProps> = (props) => {
  return (
    <Input
      id={props.id}
      name={props.name}
      placeholder={props.placeholder}
      type={props.type}
    />
  );
};

export default InputBox;
