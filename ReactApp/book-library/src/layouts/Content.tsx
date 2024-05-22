import { Row } from "reactstrap";
import { ContentHeader } from "./Views/ContentHeader";

interface IContentProps {}

export const Content: React.FC<IContentProps> = () => {
  return (
    <div>
      <div id="content-header">
        <ContentHeader />
      </div>
      <div id="content-popular"></div>
    </div>
  );
};
