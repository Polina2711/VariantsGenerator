using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateExamVariants
{
    public class Factory
    {

        static Factory _default;

        public static Factory Default
        {
            get
            {
                if (_default == null)
                    _default = new Factory();
                return _default;
            }
        }

        private IVariantGenerator _variantGenerator;
        private IOutputFormer _outputFormer;
        private IPDFWriter _pdfWriter;

        public IVariantGenerator GetVarientGenerator()
        {
            //if (_variantGenerator == null)
                _variantGenerator = new VariantGenerator();
            return _variantGenerator;
        }

        public IVariantGenerator GetBaseVarientGenerator()
        {
            //if (_variantGenerator == null)
                _variantGenerator = new BaseVariantGenerator();
            return _variantGenerator;
        }

        public IOutputFormer GetOutputFormer()
        {
            //if (_outputFormer == null)
                _outputFormer = new OutputFormer();
            return _outputFormer;
        }

        public IOutputFormer GetBaseOutputFormer()
        {
            //if (_outputFormer == null)
                _outputFormer = new BaseOutputFormer();
            return _outputFormer;
        }

        public IPDFWriter GetPDFWriter()
        {
            //if (_pdfWriter == null)
                _pdfWriter = new PDFWriter();
            return _pdfWriter;
        }

        public IPDFWriter GetBasePDFWriter()
        {
            //if (_pdfWriter == null)
                _pdfWriter = new BasePDFWriter();
            return _pdfWriter;
        }
    }
}

