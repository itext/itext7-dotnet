/*
This file is part of the iText (R) project.
Copyright (c) 1998-2020 iText Group NV
Authors: iText Software.

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License version 3
as published by the Free Software Foundation with the addition of the
following permission added to Section 15 as permitted in Section 7(a):
FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
ITEXT GROUP. ITEXT GROUP DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
OF THIRD PARTY RIGHTS

This program is distributed in the hope that it will be useful, but
WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License
along with this program; if not, see http://www.gnu.org/licenses or write to
the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
Boston, MA, 02110-1301 USA, or download the license from the following URL:
http://itextpdf.com/terms-of-use/

The interactive user interfaces in modified source and object code versions
of this program must display Appropriate Legal Notices, as required under
Section 5 of the GNU Affero General Public License.

In accordance with Section 7(b) of the GNU Affero General Public License,
a covered work must retain the producer line in every PDF that is created
or manipulated using iText.

You can be released from the requirements of the license by purchasing
a commercial license. Buying such a license is mandatory as soon as you
develop commercial activities involving the iText software without
disclosing the source code of your own applications.
These activities include: offering paid services to customers as an ASP,
serving PDFs on the fly in a web application, shipping iText with a closed
source product.

For more information, please contact iText Software Corp. at this
address: sales@itextpdf.com
*/
using System;
using iText.Layout.Font;
using iText.StyledXmlParser.Css.Media;
using iText.StyledXmlParser.Resolver.Resource;
using iText.Svg.Processors;
using iText.Svg.Renderers.Factories;

namespace iText.Svg.Processors.Impl {
    /// <summary>
    /// Default and fallback implementation of
    /// <see cref="iText.Svg.Processors.ISvgConverterProperties"/>
    /// for
    /// <see cref="DefaultSvgProcessor"/>.
    /// </summary>
    public class SvgConverterProperties : ISvgConverterProperties {
        /// <summary>The media device description.</summary>
        private MediaDeviceDescription mediaDeviceDescription;

        /// <summary>The font provider.</summary>
        private FontProvider fontProvider;

        /// <summary>The base URI.</summary>
        private String baseUri = "";

        /// <summary>The resource retriever.</summary>
        private IResourceRetriever resourceRetriever;

        private ISvgNodeRendererFactory rendererFactory;

        private String charset = System.Text.Encoding.UTF8.Name();

        /// <summary>
        /// Creates a new
        /// <see cref="SvgConverterProperties"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// Creates a new
        /// <see cref="SvgConverterProperties"/>
        /// instance.
        /// Instantiates its members, IResourceRetriever and ISvgNodeRendererFactory, to its default implementations.
        /// </remarks>
        public SvgConverterProperties() {
            this.resourceRetriever = new DefaultResourceRetriever();
            this.rendererFactory = new DefaultSvgNodeRendererFactory();
        }

        public virtual iText.Svg.Processors.Impl.SvgConverterProperties SetRendererFactory(ISvgNodeRendererFactory
             rendererFactory) {
            this.rendererFactory = rendererFactory;
            return this;
        }

        public virtual iText.Svg.Processors.Impl.SvgConverterProperties SetFontProvider(FontProvider fontProvider) {
            this.fontProvider = fontProvider;
            return this;
        }

        public virtual ISvgNodeRendererFactory GetRendererFactory() {
            return this.rendererFactory;
        }

        public virtual String GetCharset() {
            // may also return null, but null will always default to UTF-8 in JSoup
            return charset;
        }

        public virtual iText.Svg.Processors.Impl.SvgConverterProperties SetCharset(String charset) {
            this.charset = charset;
            return this;
        }

        /// <summary>Gets the base URI.</summary>
        /// <returns>the base URI</returns>
        public virtual String GetBaseUri() {
            return baseUri;
        }

        /// <summary>Gets the font provider.</summary>
        /// <returns>the font provider</returns>
        public virtual FontProvider GetFontProvider() {
            return fontProvider;
        }

        /// <summary>Gets the media device description.</summary>
        /// <returns>the media device description</returns>
        public virtual MediaDeviceDescription GetMediaDeviceDescription() {
            return mediaDeviceDescription;
        }

        /// <summary>Sets the media device description.</summary>
        /// <param name="mediaDeviceDescription">the media device description</param>
        /// <returns>the ConverterProperties instance</returns>
        public virtual iText.Svg.Processors.Impl.SvgConverterProperties SetMediaDeviceDescription(MediaDeviceDescription
             mediaDeviceDescription) {
            this.mediaDeviceDescription = mediaDeviceDescription;
            return this;
        }

        /// <summary>Sets the base URI.</summary>
        /// <param name="baseUri">the base URI</param>
        /// <returns>the ConverterProperties instance</returns>
        public virtual iText.Svg.Processors.Impl.SvgConverterProperties SetBaseUri(String baseUri) {
            this.baseUri = baseUri;
            return this;
        }

        /// <summary>Gets the resource retriever.</summary>
        /// <remarks>
        /// Gets the resource retriever.
        /// The resourceRetriever is used to retrieve data from resources by URL.
        /// </remarks>
        /// <returns>the resource retriever</returns>
        public virtual IResourceRetriever GetResourceRetriever() {
            return resourceRetriever;
        }

        /// <summary>Sets the resource retriever.</summary>
        /// <remarks>
        /// Sets the resource retriever.
        /// The resourceRetriever is used to retrieve data from resources by URL.
        /// </remarks>
        /// <param name="resourceRetriever">the resource retriever</param>
        /// <returns>
        /// the
        /// <see cref="SvgConverterProperties"/>
        /// instance
        /// </returns>
        public virtual iText.Svg.Processors.Impl.SvgConverterProperties SetResourceRetriever(IResourceRetriever resourceRetriever
            ) {
            this.resourceRetriever = resourceRetriever;
            return this;
        }
    }
}
